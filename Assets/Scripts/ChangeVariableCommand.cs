using UnityEngine;
using Fungus;

[CommandInfo("Custom",
             "Change Variable",
             "Changes a custom variable in a script.")]
public class ChangeVariableCommand : Command
{
    public enum Operation { Set, Add, Subtract, Multiply, Divide }

    [Tooltip("The GameObject that contains the script.")]
    public GameObject targetObject;

    [Tooltip("The script that contains the variable.")]
    public MonoBehaviour targetScript;

    [Tooltip("The name of the variable to change.")]
    public string variableName;

    [Tooltip("The operation to perform on the variable.")]
    public Operation operation;

    [Tooltip("The value to use in the operation.")]
    public float value;

    public override void OnEnter()
    {
        // Use reflection to get the variable from the script
        var variable = targetScript.GetType().GetField(variableName);

        // If the variable was found, perform the operation on it
        if (variable != null)
        {
            float currentValue = (float)variable.GetValue(targetScript);

            switch (operation)
            {
                case Operation.Set:
                    variable.SetValue(targetScript, value);
                    break;
                case Operation.Add:
                    variable.SetValue(targetScript, currentValue + value);
                    break;
                case Operation.Subtract:
                    variable.SetValue(targetScript, currentValue - value);
                    break;
                case Operation.Multiply:
                    variable.SetValue(targetScript, currentValue * value);
                    break;
                case Operation.Divide:
                    variable.SetValue(targetScript, currentValue / value);
                    break;
            }
        }
        else
        {
            Debug.LogError("Variable " + variableName + " not found in script " + targetScript);
        }

        Continue();
    }
}