//try-catch block
try 
{
    // the try block containing normal code that may throw an error
}
catch ( ExceptionType ex) //there are multiple exception types
{

}
finally //optional
{

}

//throwing an exception defined in System.Exception
Exception ex = new Exception("A fatal error!");
throw ex;