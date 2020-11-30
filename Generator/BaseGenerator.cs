using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class BaseGenerator : IGenerator
    {
        protected List<IBaseGenerator> generators;


        public BaseGenerator()
        {
            generators = new List<IBaseGenerator>();
        }

        public void AddGenerator(IBaseGenerator generator)
        {
            generators.Add(generator);
        }

        public virtual object Generate(Type type)
        {
            foreach (var generator in generators)
            {
                if (generator.GeneratingType == type)
                    return generator.Generate();
            }

            return null;
        }
    }

    public class UriGenerator : IBaseGenerator
    {
        private readonly string[] sitenames =
            {"tut", "oz", "litres", "litnet", "loveread", "mybook", "best-book"};

        private readonly string[] hosts = { "ru", "com", "by", "net", "uk", "kz", "org" };
        protected Random random = new Random();

        public Type GeneratingType
        {
            get { return typeof(Uri); }
        }


        public object Generate()
        {
            return new Uri(String.Format("https://{0}.{1}", sitenames[random.Next(sitenames.Length)],
                hosts[random.Next(hosts.Length)]));
        }
    }
}
