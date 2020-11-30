using System;
using Generator;

namespace PrimetiveGenerators
{
    public abstract class PrimetiveGenerator : IBaseGenerator
    {
        protected Random random = new Random();
        public abstract Type GeneratingType { get; }

        public abstract object Generate();
    }

    public class IntGenerator : PrimetiveGenerator
    {
        public override Type GeneratingType
        {
            get { return typeof(int); }
        }

        public override object Generate()
        {
            return random.Next();
        }
    }

    public class LongGenerator : PrimetiveGenerator
    {
        public override Type GeneratingType
        {
            get { return typeof(long); }
        }

        public override object Generate()
        {
            return ((long)random.Next()) * random.Next();
        }
    }

    public class DoubleGenerator : PrimetiveGenerator
    {
        public override Type GeneratingType
        {
            get { return typeof(double); }
        }

        public override object Generate()
        {
            return random.NextDouble();
        }
    }

    public class FloatGenerator : PrimetiveGenerator
    {
        public override Type GeneratingType
        {
            get { return typeof(float); }
        }

        public override object Generate()
        {
            return (float)random.NextDouble();
        }
    }
}
