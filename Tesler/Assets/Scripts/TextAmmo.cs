using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAmmo : MonoBehaviour
{
    private TextMeshProUGUI textAmmo;
    public Vector3 offset = new Vector3(0, 0.1f);
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        textAmmo = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textAmmo.SetText($"you have {PlayerController.ammo.ToString()} ammo");
        transform.SetPositionAndRotation(player.transform.position + offset, new Quaternion());
    }
}
