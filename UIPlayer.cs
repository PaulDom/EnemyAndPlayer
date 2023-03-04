using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour
{
    public Player player_script;
    public Slider slider_health;

    private void Update()
    {
        slider_health.maxValue = player_script.max_health;
        slider_health.value = player_script.health;
    }
}
