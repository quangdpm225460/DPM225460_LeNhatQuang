namespace DPM225460_LeNhatQuang_Pattern02_Builder
{
    internal class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}