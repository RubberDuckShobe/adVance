using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace adVance
{
    class OLDTVResources : MonoBehaviour
    {
        //Currently unused - feel free to add something if you want to
        private GamePlay gp;

        void Awake()
        {
            StartCoroutine(GetRequired());
        }

        IEnumerator GetRequired()
        {
            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<GamePlay>().Any());
            gp = Resources.FindObjectsOfTypeAll<GamePlay>().FirstOrDefault();
        }
    }
}
