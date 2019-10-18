using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TestCalculator
{
    /// <summary>
    /// We will use this class to wrap Fortran subroutines and update our answer textbox
    /// </summary>
    class Fortan
    {
        public event Action<string> UpdateTxt; //Is used to update our answer textbox
        int temp; // to be set equal to progress
        float tempFloat;
        // Delegate type.
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] // Enables call function
        public delegate void ActionRefInt(ref int progress); // Important the int is passed by ref (else we could use built-in Action<T> instead of delegate).
        public delegate void ActionRefFloat(ref float progress);
        // Delegate variable.
        public ActionRefInt callbackHandler; // Allows us to pass data to Fortran subroutine
        public ActionRefFloat newCallBackHandler; // This is for a function not yet implemented

        public Fortan()
        {
            callbackHandler = new ActionRefInt(OnUpdateProgress);
            newCallBackHandler = new ActionRefFloat(NewOnUpdateProgress); // For future function
        }

        /// <summary>
        /// Updates temp from progress
        /// </summary>
        /// <param name="progress"> Returned integer from Fortran subroutine</param>
        public void OnUpdateProgress(ref int progress)
        {
           temp = progress; 
        }

        /// <summary>
        /// For future function
        /// </summary>
        /// <param name="progress"></param>
        public void NewOnUpdateProgress(ref float progress)
        {
            tempFloat = progress;
        }

        /// <summary>
        /// Takes two integers, and passes them into wrapped Fortran subroutine
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void Addition(int first, int second)
        {
            addition(ref first, ref second, this.callbackHandler); // call to Fortran subroutine(see bottom of code)
            UpdateTxt(temp.ToString()); //after the above call to Fortran is finished, updates the answer box 
        }

        public void Multiplication(int first, int second)
        {
            multiplication(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }

        //Works as above function but for subtraction of integers
        public void Subtraction(int first, int second)
        {
            subtraction(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }

        // Works as above function but for division of integers
        public void Divide(int first, int second)
        {
            division(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }

        //Unifinshed function
        public void DivideDiff(int first, int second)
        {
            float tempFirst = Convert.ToSingle(first);
            float tempSecond = Convert.ToSingle(second);
            divisiondif(ref tempFirst, ref tempSecond, this.newCallBackHandler);
            UpdateTxt(tempFloat.ToString());

        }

        /// <summary>
        /// Two lines of code, first line calls the DLL that holds the subroutines. This first string can be a file path.
        /// Entry point is case sensative and needs to exactly match the subroutine name
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="callBack">The connection to the Fortran subroutine, and the value to be returned.</param>
        [DllImport("Calculate.dll", EntryPoint = "addition", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)] 
        public static extern void addition(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        // The next 3 blocks work as the block above.
        [DllImport("Calculate.dll", EntryPoint = "multiplication", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void multiplication(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        [DllImport("Calculate.dll", EntryPoint = "subtraction", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void subtraction(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        [DllImport("Calculate.dll", EntryPoint = "division", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void division(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        //not used yet
        [DllImport("Calculate.dll", EntryPoint = "divisiondif", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void divisiondif(ref float first, ref float second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefFloat callBack);
    }
}
