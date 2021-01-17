using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace MEF
{
    [Export(typeof(ICalculator))]
    class MySimpleCalculator : ICalculator
    {
        public string Calculate(string input)
        {
            int left;
            int right;
            char operation;
            // Finds the operator.
            int fn = FindFirstNonDigit(input);
            if (fn < 0) return "Could not parse command.";

            try
            {
                // Separate out the operands.
                left = int.Parse(input.Substring(0, fn));
                right = int.Parse(input.Substring(fn + 1));
            }
            catch
            {
                return "Could not parse command.";
            }

            operation = input[fn];

            foreach (Lazy<IOperation, IOperationData> i in operations)
            {
                if (i.Metadata.Symbol.Equals(operation)) return i.Value.Operate(left, right).ToString();
            }
            return "Operation Not Found!";
        }

        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationData>> operations;

        [Export(typeof(IOperation))]
        [ExportMetadata("Symbol", '+')]
        class Add : IOperation
        {
            public int Operate(int left, int right)
            {
                return left + right;
            }

            //Nueva Operacion en la clase
            [Export(typeof(IOperation))]
            [ExportMetadata("Symbol", '-')]
            class Subtract : IOperation
            {
                public int Operate(int left, int right)
                {
                    return left - right;
                }
            }
        }

        private int FindFirstNonDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i])) return i;
            }
            return -1;
        }

    }
}
