using BenchmarkDotNet.Attributes;

namespace Matrix_Move_To_By_Degrees
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ProgramBenchmarks
    {
        private static readonly Matrix MatrixClass = new Matrix();

        [Benchmark(Baseline = true)]
        public void MoveByDegreesWIthListType()
        {
            MatrixClass.MoveByDegreesWithListType(Program.arrWithList);
        }

        [Benchmark]
        public void MoveByDegrees()
        {
            MatrixClass.MoveByDegrees(Program.arr);
        }
    }
}
