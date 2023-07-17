using UnityEngine;
using Fungus;

[CommandInfo("Custom",
             "Check Script Variable",
             "Checks a variable on a script and executes one of two commands based on the result.")]
public class CheckScriptVariable : Command
{
    public enum VariableType { Float, Int, Bool, String }
    public enum CompareOperator { Equal, Greater, Less }

    [Tooltip("The GameObject that contains the script.")]
    public GameObject targetObject;

    [Tooltip("The script that contains the variable.")]
    public MonoBehaviour targetScript;

    [Tooltip("The name of the variable to check.")]
    public string variableName;

    [Tooltip("The type of the variable.")]
    public VariableType variableType;

    [Tooltip("The operation to perform on the variable.")]
    public CompareOperator operation;

    [Tooltip("The float value to compare the variable to.")]
    public float compareValueFloat;

    [Tooltip("The int value to compare the variable to.")]
    public int compareValueInt;

    [Tooltip("The bool value to compare the variable to.")]
    public bool compareValueBool;

    [Tooltip("The string value to compare the variable to.")]
    public string compareValueString;

    [Tooltip("The index of the command to execute if the condition is true.")]
    public int trueCommandIndex;

    [Tooltip("The index of the command to execute if the condition is false.")]
    public int falseCommandIndex;

    public override void OnEnter()
    {
        bool condition = false;

        // Use reflection to get the variable from the script
        var variable = targetScript.GetType().GetField(variableName);

        // If the variable was found, perform the operation on it
        if (variable != null)
        {
            switch (variableType)
            {
                case VariableType.Float:
                    float currentValueFloat = (float)variable.GetValue(targetScript);
                    condition = Compare(currentValueFloat, compareValueFloat);
                    break;
                case VariableType.Int:
                    int currentValueInt = (int)variable.GetValue(targetScript);
                    condition = Compare(currentValueInt, compareValueInt);
                    break;
                case VariableType.Bool:
                    bool currentValueBool = (bool)variable.GetValue(targetScript);
                    condition = (currentValueBool == compareValueBool);
                    break;
                case VariableType.String:
                    string currentValueString = (string)variable.GetValue(targetScript);
                    condition = (currentValueString == compareValueString);
                    break;
            }
        }
        else
        {
            Debug.LogError("Variable " + variableName + " not found in script " + targetScript);
        }

        if (condition)
        {
            Continue(trueCommandIndex);
        }
        else
        {
            Continue(falseCommandIndex);
        }
    }

    private bool Compare(float value1, float value2)
    {
        switch (operation)
        {
            case CompareOperator.Equal:
                return value1 == value2;
            case CompareOperator.Greater:
                return value1 > value2;
            case CompareOperator.Less:
                return value1 < value2;
            default:
                return false;
        }
    }

    private bool Compare(int value1, int value2)
    {
        switch (operation)
        {
            case CompareOperator.Equal:
                return value1 == value2;
            case CompareOperator.Greater:
                return value1 > value2;
            case CompareOperator.Less:
                return value1 < value2;
            default:
                return false;
        }
    }

    public override string GetSummary()
    {
        if (targetObject == null)
        {
            return "Error: No target GameObject";
        }

        return targetObject.name + "." + variableName;
    }

    public override Color GetButtonColor()
    {
        return new Color32(235, 191, 217, 255);
    }
}
