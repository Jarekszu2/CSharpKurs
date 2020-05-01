using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentDiary.Tests
{
    [TestClass]
    public class DiaryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool value = true;
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(1);
            diary.AddRating(2);
            diary.AddRating(3);

            DiaryStatistics diaryStatistics = diary.ComputeStatistics();

            Assert.AreEqual(3, diaryStatistics.MaxGrade);
        }
    }
}
