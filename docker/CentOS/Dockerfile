FROM centos:7

RUN yum -y install gcc rpm-build rpm-devel rpmlint make python bash coreutils diffutils patch rpmdevtools

VOLUME [ "/sys/fs/cgroup" ]
CMD ["/usr/sbin/init"]