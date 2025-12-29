using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MineOre : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Animator pickaxeAnimator;
    [SerializeField] private Animator oreAnimator;

    public void Mine()
    {
        pickaxeAnimator.Play("Hit", 0, 0);
        oreAnimator.Play("Hit", 0, 0);
        GameOreManager.instance.AddOresMined(1);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Mine();
    }
}
