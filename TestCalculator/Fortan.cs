using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TestCalculator
{
    class Fortan
    {
        public event Action<string> UpdateTxt;
        int temp;
        float tempFloat;
        // Delegate type.
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ActionRefInt(ref int progress); // Important the int is passed by ref (else we could use built-in Action<T> instead of delegate).
        public delegate void ActionRefFloat(ref float progress);
        // Delegate variable.
        public ActionRefInt callbackHandler;
        public ActionRefFloat newCallBackHandler;

        public Fortan()
        {
            callbackHandler = new ActionRefInt(OnUpdateProgress);
            newCallBackHandler = new ActionRefFloat(NewOnUpdateProgress);
        }

        public void OnUpdateProgress(ref int progress)
        {
           temp = progress;
        }

        public void NewOnUpdateProgress(ref float progress)
        {
            tempFloat = progress;
        }

        public void Addition(int first, int second)
        {
            addition(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }

        public void Multiplication(int first, int second)
        {
            multiplication(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }

        public void Subtraction(int first, int second)
        {
            subtraction(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }

        public void Divide(int first, int second)
        {
            division(ref first, ref second, this.callbackHandler);
            UpdateTxt(temp.ToString());
        }
        public void DivideDiff(int first, int second)
        {
            float tempFirst = Convert.ToSingle(first);
            float tempSecond = Convert.ToSingle(second);
            divisiondif(ref tempFirst, ref tempSecond, this.newCallBackHandler);
            UpdateTxt(tempFloat.ToString());

        }

        [DllImport("Calculate.dll", EntryPoint = "addition", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void addition(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        [DllImport("Calculate.dll", EntryPoint = "multiplication", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void multiplication(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        [DllImport("Calculate.dll", EntryPoint = "subtraction", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void subtraction(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        [DllImport("Calculate.dll", EntryPoint = "division", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void division(ref int first, ref int second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefInt callBack);

        [DllImport("Calculate.dll", EntryPoint = "divisiondif", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void divisiondif(ref float first, ref float second, [MarshalAs(UnmanagedType.FunctionPtr)] ActionRefFloat callBack);
    }
}
