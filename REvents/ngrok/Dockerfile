FROM mcr.microsoft.com/dotnet/aspnet AS final

COPY "ngrok.asc" "/etc/apt/trusted.gpg.d/ngrok.asc"
RUN echo "deb https://ngrok-agent.s3.amazonaws.com buster main" > "/etc/apt/sources.list.d/ngrok.list"
RUN apt update && apt install ngrok

RUN ngrok config add-authtoken 2jm2Rhb25M20TPHn4aB6oWYoOTg_2PvNDgRbR7cmYztMNQoXX

ENTRYPOINT ["bash"]