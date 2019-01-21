FROM centos/systemd

RUN rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm
RUN yum -y update

RUN yum -y install gcc rpm-build rpm-devel rpmlint make python bash coreutils diffutils patch rpmdevtools
RUN yum -y install dotnet-sdk-2.2

RUN yum -y install httpd; yum clean all; systemctl enable httpd.service

EXPOSE 80

CMD ["/usr/sbin/init"]