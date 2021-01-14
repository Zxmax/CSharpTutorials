using System;
using System.Globalization;
using CSharpTutorials.Autofac.Model.Interface;

namespace CSharpTutorials.Autofac.Model
{
    public class TodayWrite:IDateWriter
    {
        private readonly IOutput _output;

        public TodayWrite(IOutput output)
        {
            _output = output;
        }
        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToString(CultureInfo.InvariantCulture));
        }
    }
}