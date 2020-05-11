using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;


public class Test 
{
    [Test]
    public void CalculatePoints_test(){
        var GameSession = new GameSession();
        var destroyedBlocks = 50;
        Var expectedPoints = 50*83;
        var points = GameSession.AddToScore();

        Assert.that(points, Is.EqualTo(expectedPoints));
    }
}
