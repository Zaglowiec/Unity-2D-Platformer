using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HeatltManager : MonoBehaviour {

	public int maxPlayerHralth;

	public static int playerHealth;
	
	//Text text;
	public Slider healthBar;

	private LevelManager levelManager;

	public bool isDead;

	private LifeManager lifeSystem;

	//private TimeManager theTime;

	private bool firstDead;

	// Use this for initialization
	void Start () 
	{
		//text = GetComponent<Text>();
		healthBar = GetComponent<Slider>();

		//playerHealth = maxPlayerHralth;
		playerHealth = PlayerPrefs.GetInt("PlayerCurrentHealth");

		//theTime = FindObjectOfType<TimeManager>();

		levelManager = FindObjectOfType<LevelManager>();

		lifeSystem = FindObjectOfType<LifeManager>();

		isDead = false;

		firstDead = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(playerHealth <= 0 && !isDead)
		{
			playerHealth = 0;
			levelManager.ReapawnPlayer();
			lifeSystem.TakeLife();
			isDead = true;
			//theTime.ResetTime();
			Debug.Log("Smierc");

			if(firstDead)
			{
				onelife();
			}
		}

		if(playerHealth > maxPlayerHralth)
			playerHealth = maxPlayerHralth;

		//text.text = "" + playerHealth;
		healthBar.value = playerHealth;
	}

	public static void HurtPlayer(int damageToGive)
	{
		playerHealth -= damageToGive;
		PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);
	}

	public void FullHealth()
	{
		//playerHealth = maxPlayerHralth;
		playerHealth = PlayerPrefs.GetInt("PlayerMaxHealth");
		PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);
	}

	public void KillPlayer()
	{
		playerHealth = 0;
	}

	public void onelife()
	{
		firstDead = false;
		lifeSystem.GiveLife();
	}



}
