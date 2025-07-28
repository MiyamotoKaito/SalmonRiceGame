using NovelGame;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEditor.Search;
using UnityEngine;

public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;
    void Start()
    {
        //最初の行のテキストを表示、または命令を実行
        string statement = GamaManager.Instance.userManager.GetCurrentSentence();
        if (GamaManager.Instance.userManager.IsStatement(statement))
        {
            GamaManager.Instance.userManager.ExecuteStatement(statement);
            GoToNextLine();
        }
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
        string sectence = GamaManager.Instance.userManager.GetCurrentSentence();
        if (GamaManager.Instance.userManager.IsStatement(sectence))
        {
            GamaManager.Instance.userManager.ExecuteStatement(sectence);
            GoToNextLine();
        }
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
