using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    public CharacterLists[] characterLists;
    private string folderpath = "CharacterLists";

    void Start()
    {
        characterLists = Resources.LoadAll<CharacterLists>(folderpath);
    }
}
