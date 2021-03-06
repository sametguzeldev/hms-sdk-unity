package org.m0skit0.android.hms.unity.nearby;

import com.huawei.hms.nearby.discovery.ScanEndpointInfo;

public interface ScanEndpointListener {
    void onFound(String endpointId, ScanEndpointInfo info);
    void onLost(String endpointId);
}
