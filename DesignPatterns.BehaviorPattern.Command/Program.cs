

using DesignPatterns.BehaviorPattern.Command;


// Receptor
Light livingRoomLight = new Light();


// Commands
LightOnCommand lightOn = new LightOnCommand(livingRoomLight);
LightOffCommand lightOff = new LightOffCommand(livingRoomLight);


// Invoker
RemoteControlInvoker remoteControl = new RemoteControlInvoker();


// Light On
remoteControl.Setcommand(lightOn);
remoteControl.PressButton();


// Light Off
remoteControl.Setcommand(lightOff);
remoteControl.PressButton();



// Undo the last action
remoteControl.Setcommand(lightOn);
remoteControl.PressButton();
remoteControl.PressUndo();