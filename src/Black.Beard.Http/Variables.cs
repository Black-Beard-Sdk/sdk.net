namespace Bb
{
    public class Variables
    {


        /// <summary>
        /// Initializes the Variables class.
        /// </summary>
        static Variables()
        {
            Root = new Variables();
            Root.AppendLast(new VariablesDictionary());
        }


        /// <summary>
        /// Singleton instance of Variables
        /// </summary>
        public static Variables? Root { get; private set; }


        /// <summary>
        /// Resolve a variable by name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resultValue"></param>
        /// <returns></returns>
        public static bool Resolve(string name, out string? resultValue)
        {

            var result = Root.TryGet(name, out resultValue);

            if (!result && Root._next != null)
                result = Root._next.TryGet(name, out resultValue);

            return result;

        }

        /// <summary>
        /// Resolve a variable by name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resultValue"></param>
        /// <returns></returns>
        public virtual bool TryGet(string name, out string resultValue)
        {
            resultValue = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);
            return resultValue != null;
        }

        /// <summary>
        /// Append a new Variables instance to the end of the chain.
        /// </summary>
        /// <param name="variables"></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static void AppendFirst(Variables variables)
        {

            if (variables == null)
                throw new System.ArgumentNullException(nameof(variables));

            if (Root != null)
            {
                var f = Root;
                variables.AppendLast(Root);
                Root = variables;
            }
            else
                Root = variables;

        }

        public void AppendLast(Variables variables)
        {

            if (variables == null)
                throw new System.ArgumentNullException(nameof(variables));

            if (_next == null)
                _next = variables;
            else
                _next.AppendLast(variables);
        }

        private Variables? _next;

    }
}