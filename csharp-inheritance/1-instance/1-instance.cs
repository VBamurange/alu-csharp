﻿using System;

public class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        return obj.GetType().IsArray;
    }
}
