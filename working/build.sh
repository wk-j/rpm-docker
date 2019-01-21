#!/bin/sh

rpmbuild --target noarch -bb /working/MyWeb.spec --define "_rpmdir /working"