using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace NovelGame
{
    public class GamaManager : MonoBehaviour
    {
        //�ʂ̃N���X����GameManager�̕ϐ��Ȃǂ��g����悤�ɂ��邽�߂̂���
        public static GamaManager Instance { get; private set; }
        public MainTextController mainTextController;
        public UserManager userManager;
        public ImageManager imageManager;
        //���[�U�[�̃X�N���v�g�́A���̍s�̐��l�A�N���b�N�̂��т�1�������Ă���
        [System.NonSerialized] public int lineNumber;
        private void Awake()
        {
            //����ŕʂ̃N���X����GameManager�̕ϐ��Ȃǂ��g����悤�ɂ���
            Instance = this;
            lineNumber = 0;
        }
    }
    
}
