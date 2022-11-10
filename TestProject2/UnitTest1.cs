using StudentServiceLib;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreIs8_ReturnLetter_A()
        {
            Student s = new Student();
            s.Score = 8.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);

        }
        [TestMethod]
        public void ScoreIs78_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 7.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);

        }
        [TestMethod]
        public void ScoreIs57_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 6.9;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);

        }
        [TestMethod]
        public void ScoreIs35_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 4;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);

        }
        [TestMethod]
        public void ScoreIsUnder35_ReturnLetter_B()
        {
            Student s = new Student();
            s.Score = 3;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);

        }
    }
}