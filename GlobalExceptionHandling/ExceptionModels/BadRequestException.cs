﻿namespace GlobalExceptionHandling.ExceptionModels;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {

    }
}