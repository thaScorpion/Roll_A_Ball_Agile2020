using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class newTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void yPushTest()
        {
           Assert.AreEqual(2f,TestBall.yPush);
        }
        [Test]
        public void xPushTest()
        {
           Assert.AreEqual(15f,TestBall.xPush);
        }
        [Test]
        public void randomFactorTest()
        {
           Assert.AreEqual(0.2f,TestBall.randomFactor);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator newTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
