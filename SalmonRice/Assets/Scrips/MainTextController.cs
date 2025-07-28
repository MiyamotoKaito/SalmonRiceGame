using NovelGame;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;
    void Start()
    {
        DisPlayText();
    }
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            GoToNextLine();
            DisPlayText();
        }
    }
    /// <summary>
    /// 次の行に移動
    /// </summary>
    public void GoToNextLine()
    {
        GamaManager.Instance.lineNumber++;
    }
    /// <summary>
    /// テキスト表示
    /// </summary>
    public void DisPlayText()
    {
        string sentence = GamaManager.Instance.userManager.GetCurrentSentence();
        _mainTextObject.text = sentence;
    }
}
