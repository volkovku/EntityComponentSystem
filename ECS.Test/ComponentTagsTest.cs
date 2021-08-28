using NUnit.Framework;

namespace ECS.Test
{
    [TestFixture]
    public class ComponentTagsTest
    {
        private struct Component1
        {
        }

        private struct Component2
        {
        }

        private struct Component3
        {
        }

        [Test]
        public void TestComponentTags()
        {
            var tag1 = Component<Component1>.Tag;
            var tag2 = Component<Component2>.Tag;
            var tag3 = Component<Component3>.Tag;

            Assert.AreEqual(0, Component<Component1>.Index);
            Assert.AreEqual(1, Component<Component2>.Index);
            Assert.AreEqual(2, Component<Component3>.Index);

            Assert.AreEqual(0b000001L, tag1);
            Assert.AreEqual(0b000010L, tag2);
            Assert.AreEqual(0b000100L, tag3);
            Assert.AreEqual(0b000101L, Component.GetTags<Component1, Component3>());
            Assert.AreEqual(0b000111L, Component.GetTags<Component1, Component2, Component3>());
        }
    }
}