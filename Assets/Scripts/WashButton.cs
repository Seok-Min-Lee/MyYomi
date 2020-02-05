using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashButton : MonoBehaviour
{
    // Wash 클릭 - CP회복
    public void OnClick()
    {
        DataController.Instance.currentCp = DataController.Instance.fullCp;
    }
}
