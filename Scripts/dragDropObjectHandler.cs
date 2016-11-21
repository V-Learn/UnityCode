using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface dragDropObjectHandler : IEventSystemHandler {

		void handleTriggerStart ();
		void handleTriggerEnd();
}
