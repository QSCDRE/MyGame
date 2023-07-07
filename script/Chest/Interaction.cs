using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Interaction2 : MonoBehaviour
{
	public Text  dodicator;
	public GameObject sas;
	public Text indicator;
	public GameObject Player;
	public Text sasicator;
	public Text sosicator;
	public GameObject bottle1;
	public GameObject bottle2;
	public GameObject bottle_activate;
	public GameObject milk1;
	public GameObject milk2;
	public GameObject milk_activate;
	public GameObject trig;
	public GameObject pod1;
	public GameObject pod2;
	public GameObject pod3;
	public GameObject pod4;



	void Update()
	{
		RaycastHit hit;
		if (trig==null)
		{
			pod2.SetActive(false);
			pod1.SetActive(true);
		}

		if (bottle_activate==null || milk_activate==null)
		{
			pod1.SetActive(false);
			pod3.SetActive(true);
		}

		if (milk_activate==null && bottle_activate==null)
		{
			pod3.SetActive(false);
			pod4.SetActive(true);
			
			if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
			{

					if (hit.collider.tag == "krovat")
					{
						dodicator.enabled = true;
						if (Input.GetKeyDown(KeyCode.E))
						{
							sas.SetActive(true);
							Player.SetActive(false);
							dodicator.enabled = false;
						}
					}
				
					else
					{
						dodicator.enabled = false;
						//indicator.text = ".";
					}
			}
						else
						{
							dodicator.enabled = false;
							//indicator.text = ".";
						}
			}

		


		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			
			if (hit.collider.tag == "bottle")
			{
				sasicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					bottle1.SetActive(false);
					bottle_activate.SetActive(true);
				}
			}
			else
			{
				sasicator.enabled = false;
				//indicator.text = ".";
			}
		}
		else
		{
			sasicator.enabled = false;
			//indicator.text = ".";
		}

		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			
			if (hit.collider.tag == "bottle_activate")
			{
				sosicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					bottle2.SetActive(true);
					Destroy(bottle_activate);
				}
			}
			else
			{
				sosicator.enabled = false;
			}
		}
		else
		{
			sosicator.enabled = false;
			//indicator.text = ".";
		}

	if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			
			if (hit.collider.tag == "milk")
			{
				sasicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					milk1.SetActive(false);
					milk_activate.SetActive(true);
				}
			}
			else
			{
				sasicator.enabled = false;
				//indicator.text = ".";
			}
		}
		else
		{
			sasicator.enabled = false;
			//indicator.text = ".";
		}

		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			
			if (hit.collider.tag == "milk_activate")
			{
				sosicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					milk2.SetActive(true);
					Destroy(milk_activate);
				}
			}
			else
			{
				sosicator.enabled = false;
			}
		}
		else
		{
			sosicator.enabled = false;
			//indicator.text = ".";
		}
		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{

			if (hit.collider.tag == "Door")
			{
				//indicator.text = "����� �";
				indicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					hit.collider.GetComponent<Item>().Interaction();
					if (hit.collider.CompareTag("Door"))
					{
						hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
					}
				}
			}
			else
			{
				indicator.enabled = false;
				//indicator.text = ".";
			}
		}
		else
		{
			indicator.enabled = false;
			//indicator.text = ".";
		}

	}

   private void OnTriggerEnter(Collider other)
    {
        Destroy(trig);
    }
} 
