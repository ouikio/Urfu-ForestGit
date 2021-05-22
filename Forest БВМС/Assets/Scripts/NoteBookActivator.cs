using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBookActivator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject book;
    [SerializeField] GameObject bookDemo;
    public void SwitchThem()
    {
        book.SetActive(!book.activeSelf);
        bookDemo.SetActive(!bookDemo.activeSelf);
    }
}
