using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class OFButtonHandler : MonoBehaviour
{
    public void createOFD() {
		EditorUtility.OpenFilePanel("File", "../", "*");
	}
}
