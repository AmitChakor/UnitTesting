using Microsoft.VisualStudio.TestTools.UnitTesting;
using WriteUnitTest.Repositories; // Add referance to the access LessonRepository class and method
using WriteUnitTest.Services; // Add referance to the access LessonService class

namespace WriteUnitTest.UnitTests.Services
{
    [TestClass]
    public class LessonServiceUnitTests
    {
        [TestMethod]
        public void UpdateLessonGrade_IsPassedTrue_Test()
        {
            // Create a LessonService class object referance
            var lessonSvc = new LessonService(); 

            // Create parametters for true test case scnerio
            var lessonId = 12;
            var grade = 98.2d; // examaple grade to update the IsPassed value to true and pass the test case
            //var grade = 60.3d;  // example grade to update the IsPassed value to false and fail the test case

            //Execute a "UpdateLessonGrade" method call with above parametters 
            // The positive test case shoulld update the boolean value IsPassed to "true" for the lesson no 12 if the grade parametter is gretter than MinimumPassingGrade i.e 80
            lessonSvc.UpdateLessonGrade(lessonId, grade);

            // Create a LessonRepository class referance to get the object with "lessonId" 12 to check for the updated "IsPassed" variable value
            var lessonRepo = new LessonRepository();
            var lesson = lessonRepo.GetLesson(lessonId);

            //Verify the condition with the return type as true to pass the test case   
            //As the lessons and Module repository returns data froo a hardcoded list the object variable value might not get updated but the test case can be tested by updating 
            //the hardcoded values of Lessons Objects in the LessonsRepositiry class
            Assert.IsTrue(lesson.IsPassed);

            //The above test case passes if the parametters passes are satisfing the conditions of MinimumPassingGrade and the record is updated as passed (i.e IsPassed=true)


        }

    }
}