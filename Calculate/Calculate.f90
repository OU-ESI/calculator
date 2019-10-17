module Calculate
    implicit none
contains
    subroutine addition(first, second, progressCallBack)
        !DEC$ ATTRIBUTES DLLEXPORT :: addition
        !DEC$ ATTRIBUTES ALIAS: 'addition' :: addition
        !DEC$ ATTRIBUTES REFERENCE :: first, second, progressCallBack
    
        external progressCallBack
        integer, intent(in) :: first
        integer, intent(inout) :: second
        integer :: i
        i = second
        second = i + first
        call progressCallBack(second)
        return
    end subroutine
    
    subroutine multiplication(first,second, progressCallBack)
        !DEC$ ATTRIBUTES DLLEXPORT :: multiplication
        !DEC$ ATTRIBUTES ALIAS: 'multiplication' :: multiplication
        !DEC$ ATTRIBUTES REFERENCE :: first, second, progressCallBack
    
        external progressCallBack
        integer, intent(in) :: first
        integer, intent(inout) :: second
        integer :: i
        i = second
        second = i * first
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
        integer :: i
        i = second
        second = first - i
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
        integer :: i
        i = second
        second = first / i
        call progressCallBack(second)
        return
    end subroutine
end module
    
    