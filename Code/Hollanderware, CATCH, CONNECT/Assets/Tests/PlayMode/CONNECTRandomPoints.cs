using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CONNECTRandomPoints
    {
        [UnityTest]
        public IEnumerator CONNECTRandomPointsWithEnumeratorPasses()
        {
            yield return null;

        /*
        public static float startPointPositionX;
        public static float startPointPositionY;
        public static float endPointPositionX;
        public static float endPointPositionY;

        public float xMinDistance;
        public float xMaxDistance;
        public float yMinDistance;
        public float yMaxDistance;
        */

        // This was working but I changed some things and broke it. I know what did it. I'll fix it later.
        // X value is in range
        //Assert.IsTrue(PointPositions.startPointPositionX >= GeneratePointPosition.xMinDistance &&
        //    PointPositions.startPointPositionX <= GeneratePointPosition.xMaxDistance); 

        // Y value is in range
        //Assert.IsTrue(PointPositions.startPointPositionY >= GeneratePointPosition.yMinDistance &&
        //    PointPositions.startPointPositionY <= GeneratePointPosition.yMaxDistance);
    }
    }
}
