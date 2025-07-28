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
        //文章中の文(ここでは一行ごと)を入れておくためのリスト
        List<string> _sentences = new List<string>();
        private void Awake()
        {
            //テキストのファイルの中身を、一行ずつリストに入れておく
            StringReader reader = new StringReader(_textFile.text);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                _sentences.Add(line);
            }
        }
        /// <summary>
        /// 現在の行の文を取得する
        /// </summary>
        /// <returns></returns>
        public string GetCurrentSentence()
        {
            return _sentences[GamaManager.Instance.lineNumber];
        }
        /// <summary>
        /// 文が命令かどうか
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public bool IsStatement(string sentence)
        {
            if (sentence[0] == '&')
            {
                return true;
            }
            return false;
        }
        public void ExecuteStatement(string sentence)
        {
            string[] words = sentence.Split(' ');
            switch (words[0])
            {
                case "&img":
                    GamaManager.Instance.imageManager.PutImage(words[1], words[2]);
                    break;
            }
        }
    }
}