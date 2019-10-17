module Calculate !Holds subroutines for addition, subtraction, multiplication, and division.
    implicit none !This means we have to specify types
contains
    subroutine addition(first, second, progressCallBack) !takes in two integers and uses progressCallBack to return answer
    !These three lines are are case sensitive. What is filled out here must match exactly to the call being made in C#
        !DEC$ ATTRIBUTES DLLEXPORT :: addition
        !DEC$ ATTRIBUTES ALIAS: 'addition' :: addition
        !DEC$ ATTRIBUTES REFERENCE :: first, second, progressCallBack
    
        external progressCallBack
        integer, intent(in) :: first !think of callin intent(in) as integer first = first
        integer, intent(inout) :: second !inout means it is passing in second and will be used to send out second also.
        second = second + first
        call progressCallBack(second)
        return
    end subroutine
    
    !The following subroutines follow the comments from above.
    subroutine multiplication(first,second, progressCallBack)
        !DEC$ ATTRIBUTES DLLEXPORT :: multiplication
        !DEC$ ATTRIBUTES ALIAS: 'multiplication' :: multiplication
        !DEC$ ATTRIBUTES REFERENCE :: first, second, progressCallBack
    
        external progressCallBack
        integer, intent(in) :: first
        integer, intent(inout) :: second
        second = second * first
        call progressCallBack(second)
        return
    end subroutine
    
    subroutine subtraction(first,second, progressCallBack)
        !DEC$ ATTRIBUTES DLLEXPORT :: subtraction
        !DEC$ ATTRIBUTES ALIAS: 'subtraction' :: subtraction
        !DEC$ ATTRIBUTES REFERENCE :: first, second, progressCallBack
    
        external progressCallBack
        integer, intent(in) :: first
        integer, intent(inout) :: second
        second = first - second
        call progressCallBack(second)
        return
    end subroutine
    
    subroutine division(first,second, progressCallBack)
        !DEC$ ATTRIBUTES DLLEXPORT :: division
        !DEC$ ATTRIBUTES ALIAS: 'division' :: division
        !DEC$ ATTRIBUTES REFERENCE :: first, second, progressCallBack
    
        external progressCallBack
        integer, intent(in) :: first
        integer, intent(inout) :: second
        second = first / second
        call progressCallBack(second)
        return
    end subroutine
end module
    
    