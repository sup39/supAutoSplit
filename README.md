# supAutoSplit
An auto splitter for LiveSplit using OpenCV and template matching.

## Installation
### Step 1. Install supAutoSplit
Download `LiveSplit.supAutoSplit.dll` from the [release page](https://github.com/sup39/supAutoSplit/releases), and put it into `(LiveSplit)\Components`
### Step 2. Install [opencvsharp](https://github.com/shimat/opencvsharp)
Download `OpenCvSharp-*.zip` (e.g. `OpenCvSharp-4.5.3-20210821.zip`) from the [release page](https://github.com/shimat/opencvsharp/releases), extract and copy:
- `(Zip)\ManagedLib\net461\OpenCvSharp.dll` to `(LiveSplit)\Components\`
- `(Zip)\NativeLib\win` (whole directory) to `(LiveSplit)\Components\`, and rename the directory to `dll`
### After the installation
There should be the following files in the `(LiveSplit)\Components` directory:
- `LiveSplit.supAutoSplit.dll`
- `OpenCvSharp.dll`
- `dll\x86\OpenCvSharpExtern.dll`
- `dll\x64\OpenCvSharpExtern.dll`

## Usage
- Right click on LiveSplit, and select `Edit Layout...`
- In Layout Editor, click the (+) button, in `Control` click `supAutoSplit`
- After adding `supAutoSplit` to the list, click the `Layout Settings` button, navigate to the `supAutoSplit` tab, add template and set the parameters
