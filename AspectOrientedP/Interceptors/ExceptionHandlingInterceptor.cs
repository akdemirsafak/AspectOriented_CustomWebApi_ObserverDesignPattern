using Castle.DynamicProxy;


namespace AspectOrientedP.Interceptors
{
    public class ExceptionHandlingInterceptor : IInterceptor
    {
       public void Intercept(IInvocation invocation)
        {
            
            System.Console.WriteLine("Exception Fırlatıldı");
        }
    }
}