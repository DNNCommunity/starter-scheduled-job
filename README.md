# starter-scheduled-job

[![License: MIT](https://img.shields.io/badge/LICENSE-MIT-informational.svg)](https://opensource.org/licenses/MIT)

**starter-scheduled-job** is a Scheduled Job starter project for [DNN Platform](https://github.com/dnnsoftware/Dnn.Platform) (formerly known as DotNetNuke) made by and for the [DNN Community](https://dnncommunity.org).

## Installation

### Installation Option #1

Clone this repo into a clean directory of your choice.

```bash
git clone https://github.com/DNNCommunity/starter-scheduled-job.git .
```

### Installation Option #2

Use **dnn-cli**, which is [available as an npm package](https://www.npmjs.com/package/@dnncommunity/dnn-cli).  **dnn-cli** it can be installed via **yarn** or **npm**.

---
#### Install dnn-cli...

...via **yarn**:

```bash
yarn global add @dnncommunity/dnn-cli
```

...via **npm**:

```bash
npm install -g @dnncommunity/dnn-cli
```
---

Once **dnn-cli** is installed, this starter project can be installed into an empty directory of your choice.

```bash
cd <directory path>
dnn scheduled-job
```

## Usage

1. Install DNN in a `.\Website` folder (root of directory in which this project is cloned)
2. Open solution file in Visual Studio 2019 (Run as Adminstrator...)
3. Build in `Debug` or `Release` mode

### Debug

By default this will compile the project and deploy it to the `.\Website` folder.  
- DLL and PDB files will be deployed to `.\Website\bin`
- All other relevant files will be deployed to `.\Website\DesktopModules\ScheduledJobs\starter-scheduled-job`

### Release

By default this will create an install package and place in `.\Website\Install\Library` so it will be in **Available Extensions** within DNN (SETTINGS > Extensions > Available Extensions).

### Implementation

To implement the scheduled job, add the following information to a new **Task** to **SETTINGS > Scheduler** within DNN while logged in as a SuperUser.

- **Friendly Name**: Starter Scheduled Job
- **Full Class Name and Assembly**: starter_scheduled_job.StarterScheduledJob, starter-scheduled-job
- **Retain Schedule History**: 5
- **Frequency**: 60 Seconds (for quick testing purposes)
- **Retry TimeLapse**: 15 Seconds (for quick testing purposes)
- **Enable Schedule**: On

In practice, the above will vary depending on use case.

## Contributing
Pull requests are welcome. Please open an issue first to document the bug or enhancement details.

## License
[![License: MIT](https://img.shields.io/badge/LICENSE-MIT-informational.svg)](https://opensource.org/licenses/MIT)