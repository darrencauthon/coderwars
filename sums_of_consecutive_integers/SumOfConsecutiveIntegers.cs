using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Should;

namespace SumOfConsecutiveIntegers
{

    public class SumOfConsecutiveIntegers
    {
        public static int Position(int count, int total, int position)
        {
            var ranges = GetRangesToConsider(count, total);
            return ranges
                .Where(x => x.Sum() == total)
                .Select(x => x.ElementAt(position))
                .First();
        }

        private static IEnumerable<IEnumerable<int>> GetRangesToConsider(int count, int total)
        {
            var edge = Math.Abs(total) + count;
            return Enumerable.Range(0 - edge, edge*2)
                .Select(x => Enumerable.Range(x, count));
        }
    }

    [TestFixture]
    public class SumOfConsecutiveIntegersTests
    {

        [Test]
        public void So_4_14_3_is_5()
        {
            // 2, 3, 4, 5
            SumOfConsecutiveIntegers.Position(4, 14, 3).ShouldEqual(5);
        }

        [Test]
        public void So_2_1_0_is_0()
        {
            // 0, 1
            SumOfConsecutiveIntegers.Position(2, 1, 0).ShouldEqual(0);
        }

        [Test]
        public void So_2_1_1_is_1()
        {
            // 0, 1
            SumOfConsecutiveIntegers.Position(2, 1, 1).ShouldEqual(1);
        }

        [Test]
        public void So_4_14_2_is_4()
        {
            // 2, 3, 4, 5
            SumOfConsecutiveIntegers.Position(4, 14, 2).ShouldEqual(4);
        }

        [Test]
        public void So_2_3_0_is_1()
        {
            SumOfConsecutiveIntegers.Position(2, 3, 0).ShouldEqual(1);
        }

        [Test]
        public void So_2_3_1_is_2()
        {
            SumOfConsecutiveIntegers.Position(2, 3, 1).ShouldEqual(2);
        }

        [Test]
        public void So_3_6_0_is_1()
        {
            SumOfConsecutiveIntegers.Position(3, 6, 0).ShouldEqual(1);
        }

        [Test]
        public void So_3_6_2_is_3()
        {
            SumOfConsecutiveIntegers.Position(3, 6, 2).ShouldEqual(3);
        }

        [Test]
        public void So_5_40_0_is_6()
        {
            // 6, 7, 8, 9, 10
            SumOfConsecutiveIntegers.Position(5, 40, 0).ShouldEqual(6);
        }

        [Test]
        public void So_5_40_1_is_7()
        {
            // 6, 7, 8, 9, 10
            SumOfConsecutiveIntegers.Position(5, 40, 1).ShouldEqual(7);
        }

        [Test]
        public void So_3_63_0_is_20()
        {
            // 20, 21, 22
            SumOfConsecutiveIntegers.Position(3, 63, 0).ShouldEqual(20);
        }

        [Test]
        public void So_3_63_1_is_21()
        {
            // 20, 21, 22
            SumOfConsecutiveIntegers.Position(3, 63, 1).ShouldEqual(21);
        }

        [Test]
        public void So_4_82_0_is_19()
        {
            // 19, 20, 21, 22
            SumOfConsecutiveIntegers.Position(4, 82, 0).ShouldEqual(19);
        }

        [Test]
        public void So_4_82_3_is_22()
        {
            // 19, 20, 21, 22
            SumOfConsecutiveIntegers.Position(4, 82, 3).ShouldEqual(22);
        }

        [Test]
        public void So_4_86_0_is_20()
        {
            // 20, 21, 22, 23
            SumOfConsecutiveIntegers.Position(4, 86, 0).ShouldEqual(20);
        }

        [Test]
        public void Codewars_example_2()
        {
            SumOfConsecutiveIntegers.Position(2, 25, 0).ShouldEqual(12);
        }

        [Test]
        public void Codewars_example_3()
        {
            SumOfConsecutiveIntegers.Position(7, 749, 5).ShouldEqual(109);
        }

        [Test]
        public void Codewars_example_4()
        {
            SumOfConsecutiveIntegers.Position(3, -9, 1).ShouldEqual(-3);
        }

        [Test]
        public void Codewars_example_5()
        {
            SumOfConsecutiveIntegers.Position(5, 0, 0).ShouldEqual(-2);
        }

        [Test]
        public void Codewars_example_6()
        {
            SumOfConsecutiveIntegers.Position(4, -446, 3).ShouldEqual(-110);
        }
    }
}
