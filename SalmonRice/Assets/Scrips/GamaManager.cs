using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace NovelGame
{
    public class GamaManager : MonoBehaviour
    {
        //別のクラスからGameManagerの変数などを使えるようにするためのもの
        public static GamaManager Instance { get; private set; }
        public MainTextController mainTextController;
        public UserManager userManager;
        public ImageManager imageManager;
        //ユーザーのスクリプトの、今の行の数値、クリックのたびに1ずつ増えていく
        [System.NonSerialized] public int lineNumber;
        private void Awake()
        {
            //これで別のクラスからGameManagerの変数などを使えるようにする
            Instance = this;
            lineNumber = 0;
        }
    }
    
}
