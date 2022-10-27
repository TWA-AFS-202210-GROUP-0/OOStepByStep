namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class IntroTest
    {
        [Fact]
        public void Should_return_name_and_age_when_intro_given_person()
        {
            // given
            var person = new Person("Tom", 21);
            // when
            var words = person.Introduce();
            // then
            Assert.Equal("My name is Tom. I am 21 years old.", words);
        }
    }
}
