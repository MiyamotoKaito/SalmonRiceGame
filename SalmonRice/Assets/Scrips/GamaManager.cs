using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace NovelGame
{
    public class GamaManager : MonoBehaviour
    {
        public static GamaManager instance;
        private void Awake()
        {
            instance = this;
        }
    }
    
}
