# TaskRunnerExtension
Task runner extension for Visual Studio

Based on Task Output Listener by Mads Kristensen
https://github.com/madskristensen/TaskOutputListener

## Features

- Error detection
- Output available in seperate output pane
- Ability to cancel the current build from a task runner task

### Error detection
Parses output from Task Runner Explorer to populate the Visual Studio Error List with any errors produced by a task in msbuild format

### Output available in seperate output pane
The output of a task runner task will be available in a seperate output pane in Visual Studio.

### Ability to cancel the current build from a task runner task
Tasks can cancel the current build by emtting the line 'cancel-build'.

## License
[Apache 2.0](LICENSE)
