using UnityEngine;
using TMPro;

public class TextAmmo : MonoBehaviour
{
    private TextMeshProUGUI textAmmo;
    public Vector3 offset = new Vector3(0, 0.1f);
    public GameObject player;
    private int lastAmmoCount = -1; // Track last ammo count to avoid unnecessary updates

    // Start is called before the first frame update
    void Start()
    {
        textAmmo = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // Only update text if ammo count changed
        if (PlayerController.ammo != lastAmmoCount)
        {
            textAmmo.SetText($"you have {PlayerController.ammo} ammo");
            lastAmmoCount = PlayerController.ammo;
        }
        
        // Update position to follow player
        transform.SetPositionAndRotation(player.transform.position + offset, new Quaternion());
    }
}
