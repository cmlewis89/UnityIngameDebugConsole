using System;


[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class ConsoleMethodAttribute : Attribute
{
	private string m_command;
	private string m_description;

	public string Command { get { return m_command; } }
	public string Description { get { return m_description; } }

	public ConsoleMethodAttribute (string command, string description)
	{
		m_command = command;
		m_description = description;
	}
}

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class ConsoleButtonAttribute : Attribute
{
	private string m_buttonTitle;
	private string m_buttonGroup = null;

	public string ButtonTitle { get { return m_buttonTitle; } }
	public bool IsGrouped { get { return !string.IsNullOrEmpty(m_buttonGroup); } }
	public string ButtonGroup { get { return m_buttonGroup; } }

	public ConsoleButtonAttribute (string buttonTitle)
	{
		m_buttonTitle = buttonTitle;
	}

	public ConsoleButtonAttribute (string buttonTitle, string buttonGrouping)
	{
		m_buttonGroup = buttonGrouping;
		m_buttonTitle = buttonTitle;
	}
}