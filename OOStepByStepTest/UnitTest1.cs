namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_person_can_introduce_himself()
        {
            // given
            var person = new Person("Tom", 21);
            // when
            var msg = person.Introduce();
            // then
            Assert.Equal(msg, "My name is Tom. I am 21 years old");
        }
    }
}