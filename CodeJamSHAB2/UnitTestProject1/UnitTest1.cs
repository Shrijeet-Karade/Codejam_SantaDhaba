using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codejam;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_valid_input_one()
        {
            var writer = new SantaDaDhaba();
            string[] prices = { "26", "14", "72", "39", "32", "85", "06" };
            int result = writer.MaxDays(prices, 13);
            Assert.AreEqual(5,result);
        }
        [TestMethod]
        public void Test_valid_input_two()
        {
            var writer = new SantaDaDhaba();
            string[] prices = { "26", "14", "72", "39", "32", "85", "06", "91" };
            int result = writer.MaxDays(prices, 20);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void Test_valid_input_three()
        {
            var writer = new SantaDaDhaba();
            string[] prices = { "Dear", "Code", "rsHa", "veFu", "nInT", "heCh", "alle", "ngeP", "hase", "andb", "ecar", "eful" };
            int result = writer.MaxDays(prices, 256);
            Assert.AreEqual(10,result);
        }
        [TestMethod]
        public void Test_dangerous()
        {
            var writer = new SantaDaDhaba();
            string[] prices = {"VtJR9K8ABiW68NsStKhlSfw9Izq", "LVVs0MAQUUYefE8kKWamNuS8L52","SN0HhVmZT6htaCPDpdLZwp8iC28", "INEJqbH7ImrqDvX7WhUjX6242sC", "k2DrJY5cMgtRxdInoEIti0OPVUR", "XWHkEIv5bTABqp2FkdWVRinLQlj", "nGBEmhUWtmPxLq5WeuWuc9Q5a8t", "tWcaJrlVdQz7KjWH4MMY1F4vpBJ", "vkRmdxOEGFzlqQjxiSRxVmJ1nW4", "gMFzHzO3bJPnXdmITAzPqQqntc5", "uNby1vCyA9MBkdbXACIRdQQ2Hqr", "4jT9cpjYqcknnu7yclX8vhOMLon", "N3bE8JgFvVwTJZC6K4EGgxomsVA", "DozyC0ZO8q4MlXIDppPt9T5O72A", "uvd26Sz4e0b26S5SBcjMRWlLeCQ", "2IRCAKpCQHCUvA3wGV1jfbQ13wn", "MaxkaFBmNVcattkLnuPhAsirXJH", "ZKCKekFPLTY5q2hQvZ8FK2e1BWh", "22yIbJSvxA8KVbrZStEqmlz151d", "4C8lDAkTl1vew5mFZO68oxMeh8d", "jBdKEnSx0cfTLgMxbSkqz6w5srR", "WYX8FhlavY0sXbY0wCLunlcbkgX", "pYME4vkCAPviKUjA1KgzErK8e3i", "GnOlau8px1X9Bw3sEXbMWt3T7sm", "EUpukdHUBBa08bVGkRJcdqB0K41", "nAtZONPG60XYBj8Arhf7R5O4iCD", "gWIhISYrowE40CcYOJeWALBGkEc", "mvp0bLIHbipTUjfYhs8DERrkaAt", "ov6Qh1FhaZxrAdfb7MFg27mFJE7", "1mHuaAy0szEXYnTNv62XENmsPre", "eAqj9cz1A90BzxPVVAyt52taGGK", "6dBjGJXzSAwUK4ST3PqYv0Um6Xf", "eluzqV8ZlQ6jqEfIXjk0lApH3pm", "ntHQY0KXqqdNZ3UIugyCBfxAQ5z", "i6oStihJEhcjYQMtzQNGK2CUDrR", "NGUMwa9ORr3j3kJmGj8AgYVuqX6", "Ljyk4CFP8nYUDNXwQHDCWuKgar9", "VffZyOVjQhwpphNHuioo841Iavb", "EUSNx52W4O2npjhcXO0oJgb7nf9", "5D2gRW6mTCp0EB0z0hgdC4bzLFa", "R2Da8Qamp7rbY1QWFaWEYCu9Owi", "NIyvj08H6WrtLwkxVlL10tWCSi6", "b40KSIILzGUENy4GKyyFThYTfSz", "rufvVjvn9C3V9KxOhvQvDOrQqYz", "JDRG2Jvxmcsam2dFCxAYc5yXHMO", "hCueT75j9Mc49DvjzxKC9IMfsPd", "QgymM8h0am4JuQuyX7rE4pZGwpa", "chzD5e9qyIVysH099P16u6x9Aki" };
            int result = writer.MaxDays(prices, 6708);
            Assert.AreEqual(48, result);
        }

    }
}
