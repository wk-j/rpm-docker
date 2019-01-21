FROM centos/systemd

WORKDIR /app
COPY my-web-1-1.noarch.rpm /app


RUN rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm
RUN yum -y update

RUN yum -y install dotnet-sdk-2.2
RUN rpm -i my-web-1-1.noarch.rpm
RUN systemctl enable MyWeb

EXPOSE 5000

CMD ["/usr/sbin/init"]