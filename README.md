[![Docker Image CI](https://github.com/j4asper/Jazper.dk/actions/workflows/docker-image.yml/badge.svg)](https://github.com/j4asper/Jazper.dk/actions/workflows/docker-image.yml)

# [Jazper.dk](https://jazper.dk)

This is the source code for my personal website, which serves as a hub for links to my social media profiles, including GitHub, LinkedIn, and other relevant networks. Additionally, the website showcases some of the projects I have developed, along with details about my work and educational experience.

## Technologies Used

- **Backend**: C# and Blazor
- **Frontend**: MudBlazor (UI component library)
- **Containerization**: Docker

## Running the Website in a Docker Container

To build and run the website in a Docker container, follow these steps:

### 1. Build the Docker Image

Run the following command in the root directory of the project to build the Docker image:

```bash
docker build -t jazperdk .
```

### 2. Run the Docker Container

After building the image, you can run the Docker container with the following command. Replace `80` with your preferred port if needed:

```bash
docker run -d -p 80:8080 jazperdk
```

### 3. Log Files

If you want to bind the logs to a local folder, the website logs are stored in the Docker container at `/logs/website.log`. You can mount a local directory to the container to store these logs outside of the container. For example:

```bash
docker run -d -p 80:8080 -v /path/to/local/logs:/logs jazperdk
```

This will bind the `/logs/website.log` file in the container to your specified local folder.

## Ports

By default, the website runs on port `8080` within the container. You can bind this to any port on your host system when running the container.
