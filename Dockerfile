FROM ubuntu:22.04

WORKDIR /game

RUN apt-get update && apt-get install -y \
    libglib2.0-0 \
    libnss3 \
    libasound2

COPY build/LinuxServer/ .

RUN chmod +x BossRoom.x86_64

EXPOSE 7777/udp

CMD ["./BossRoom.x86_64", "-batchmode", "-nographics"]
