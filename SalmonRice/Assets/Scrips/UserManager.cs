using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Scripting;

namespace NovelGame
{
    public class UserManager : MonoBehaviour
    {
        [SerializeField]TextAsset _textFile;
        //���͒��̕�(�����ł͈�s����)�����Ă������߂̃��X�g
        List<string> _sentences = new List<string>();
        private void Awake()
        {
            //�e�L�X�g�̃t�@�C���̒��g���A��s�����X�g�ɓ���Ă���
            StringReader reader = new StringReader(_textFile.text);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                _sentences.Add(line);
            }
        }
        /// <summary>
        /// ���݂̍s�̕����擾����
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSentence()
        {
            return _sentences[GamaManager.Instance.lineNumber];
        }
    }
}