namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_say_name_and_age_when_self_introduce_given_name_Tom_age_21()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            var introduction = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }
    }
}
