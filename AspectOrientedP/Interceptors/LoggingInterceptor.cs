using Castle.DynamicProxy;

namespace AspectOrientedP.Interceptors
{
    public class LoggingInterceptor:IInterceptor
    {
       
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"Executinsg {invocation.Method.Name} with parameters: " +
                              string.Join(", ", invocation.Arguments.Select(a => a?.ToString()).ToArray()));

            // Invoke the method
            invocation.Proceed();

            Console.WriteLine($"Finished executing {invocation.Method}");
        }
        
    }
}