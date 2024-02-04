namespace Television.Tests
{
    using System;
    using NUnit.Framework;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSwitchOn()
        {
            // Arrange
            var tv = new TelevisionDevice("Sony", 500, 1920, 1080);

            // Act
            string result = tv.SwitchOn();

            // Assert
            Assert.AreEqual("Cahnnel 0 - Volume 13 - Sound On", result);
        }

        [Test]
        public void TestChangeChannel_ValidChannel()
        {
            // Arrange
            var tv = new TelevisionDevice("LG", 600, 1920, 1080);

            // Act
            int newChannel = tv.ChangeChannel(5);

            // Assert
            Assert.AreEqual(5, newChannel);
        }

        [Test]
        public void TestChangeChannel_InvalidChannel()
        {
            // Arrange
            var tv = new TelevisionDevice("Samsung", 700, 1920, 1080);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => tv.ChangeChannel(-1));
        }

        [Test]
        public void TestVolumeChange_Up()
        {
            // Arrange
            var tv = new TelevisionDevice("Sony", 500, 1920, 1080);

            // Act
            string result = tv.VolumeChange("UP", 10);

            // Assert
            Assert.AreEqual("Volume: 23", result);
        }

        [Test]
        public void TestVolumeChange_Down()
        {
            // Arrange
            var tv = new TelevisionDevice("LG", 600, 1920, 1080);

            // Act
            string result = tv.VolumeChange("DOWN", 5);

            // Assert
            Assert.AreEqual("Volume: 8", result);
        }

        [Test]
        public void TestVolumeChange_ExceedMaxVolume()
        {
            // Arrange
            var tv = new TelevisionDevice("Samsung", 700, 1920, 1080);

            // Act
            string result = tv.VolumeChange("UP", 100);

            // Assert
            Assert.AreEqual("Volume: 100", result);
        }

        [Test]
        public void TestVolumeChange_LowerThanZero()
        {
            // Arrange
            var tv = new TelevisionDevice("Sony", 500, 1920, 1080);

            // Act
            string result = tv.VolumeChange("DOWN", 20);

            // Assert
            Assert.AreEqual("Volume: 0", result);
        }

        [Test]
        public void TestMuteDevice()
        {
            // Arrange
            var tv = new TelevisionDevice("LG", 600, 1920, 1080);

            // Act
            bool isMuted = tv.MuteDevice();

            // Assert
            Assert.IsTrue(isMuted);

            // Act again
            isMuted = tv.MuteDevice();

            // Assert
            Assert.IsFalse(isMuted);
        }

        [Test]
        public void TestToString()
        {
            // Arrange
            var tv = new TelevisionDevice("Samsung", 700, 1920, 1080);

            // Act
            string result = tv.ToString();

            // Assert
            Assert.AreEqual("TV Device: Samsung, Screen Resolution: 1920x1080, Price 700$", result);
        }
    }
}